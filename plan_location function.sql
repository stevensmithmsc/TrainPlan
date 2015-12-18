create function train.plan_location
	(@startdate datetime,
	 @enddate datetime,
	 @incweekend bit = 0) 
	RETURNS @t TABLE ([Date] date not null, 
					[Day] varchar(10) not null,
					Location varchar(50) not null,
					[Time] char(2) not null,
					Course varchar(80) null,
					Trainer varchar(50) null,
					Bookings int null,
					Available int null,
					Colour varchar(8) null)		
begin	
 
 insert into @t
 select d.[Date], DATENAME(dw, d.[Date]) as [Day], Locations.Location, d.[Time],
		coursesess.Course, coursesess.Trainer, coursesess.Bookings, coursesess.Available, '#' + right(master.dbo.fn_varbintohexstr(coursesess.ARGB_Colour), 6)
	from train.plandates(@startdate, @enddate, @incweekend) d cross join train.Locations 
		left join (select Sess.Location, 
			CAST(strt as DATE) [Date], 
			case when DATEPART(hh, Sess.Strt) < 12 then 'AM' else 'PM' end as [AM/PM], 
			Courses.Course, 
			isnull(Staff.PName, Staff.Fname + ' ' + Staff.Sname) as Trainer, 
			(select COUNT(*) from train.Attendance where isnull(Outcome, 0) not in (6, 7) and Attendance.Sess = Sess.ID) as [Bookings], 
			Sess.MaxP - (select COUNT(*) from train.Attendance where isnull(Outcome, 0) not in (6, 7) and Attendance.Sess = Sess.ID) as [Available], 
			Courses.Paris,
			case when (Sess.MaxP <= (select COUNT(*) from train.Attendance where isnull(Outcome, 0) not in (6, 7) and Attendance.Sess = Sess.ID)) then ISNULL(Courses.FullColour, (select Colour from train.category where ID = (case Courses.Paris when 1 then 3 else 6 End)))
				when (select COUNT(*) from train.Attendance where isnull(Outcome, 0) not in (6, 7) and Attendance.Sess = Sess.ID) > 0 then ISNULL(Courses.BookedColour, (select Colour from train.category where ID = (case Courses.Paris when 1 then 2 else 5 End)))
				else ISNULL(Courses.EmptyColour, (select Colour from train.category where ID = (case Courses.Paris when 1 then 1 else 4 End))) end as ARGB_Colour
		from train.Sess  
			left join train.Courses on Sess.Course = Courses.ID
			left join train.Staff on Sess.Trainer = Staff.ID
		where Sess.MaxP > 0
		union
		select OtherActivity.Location, OtherActivity.[Date], OtherActivity.[Time],
			OtherActivity.Description, isnull(Staff.PName, Staff.Fname + ' ' + Staff.Sname) as Trainer, null, null, null,
			category.Colour
		from train.OtherActivity
			left join train.Staff on OtherActivity.Trainer = Staff.ID
			left join train.category on OtherActivity.Category = category.ID
		where OtherActivity.Location is not null) coursesess on d.[Date] = coursesess.[Date] and Locations.ID = coursesess.Location and d.[Time] = coursesess.[AM/PM]
	where Locations.TLoc = 1
	order by Locations.Location, d.[Date], d.[Time]
	
	return
end