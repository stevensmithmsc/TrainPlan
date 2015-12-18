create function train.plan_trainer
	(@startdate datetime,
	 @enddate datetime,
	 @incweekend bit = 0) 
	RETURNS @t TABLE ([Date] date not null, 
					[Day] varchar(10) not null,
					Trainer varchar(50) not null,
					[Time] char(2) not null,
					Course varchar(80) null,
					Location varchar(50) null,
					Bookings int null,
					Available int null,
					Colour varchar(8) null)		
begin	
 
 insert into @t
 select d.[Date], DATENAME(dw, d.[Date]) as [Day], isnull(Staff.PName, Staff.Fname + ' ' + Staff.Sname) as Trainer, d.[Time],
		coursesess.Course, coursesess.Location, coursesess.Bookings, coursesess.Available, '#' + right(master.dbo.fn_varbintohexstr(coursesess.ARGB_Colour), 6)
	from train.plandates(@startdate, @enddate, @incweekend) d cross join train.Staff 
		left join (select Sess.Trainer, 
			CAST(strt as DATE) [Date], 
			case when DATEPART(hh, Sess.Strt) < 12 then 'AM' else 'PM' end as [AM/PM], 
			Courses.Course, 
			Locations.Location, 
			(select COUNT(*) from train.Attendance where isnull(Outcome, 0) not in (6, 7) and Attendance.Sess = Sess.ID) as [Bookings], 
			Sess.MaxP - (select COUNT(*) from train.Attendance where isnull(Outcome, 0) not in (6, 7) and Attendance.Sess = Sess.ID) as [Available], 
			Courses.Paris,
			case when (Sess.MaxP <= (select COUNT(*) from train.Attendance where isnull(Outcome, 0) not in (6, 7) and Attendance.Sess = Sess.ID)) then ISNULL(Courses.FullColour, (select Colour from train.category where ID = (case Courses.Paris when 1 then 3 else 6 End)))
				when (select COUNT(*) from train.Attendance where isnull(Outcome, 0) not in (6, 7) and Attendance.Sess = Sess.ID) > 0 then ISNULL(Courses.BookedColour, (select Colour from train.category where ID = (case Courses.Paris when 1 then 2 else 5 End)))
				else ISNULL(Courses.EmptyColour, (select Colour from train.category where ID = (case Courses.Paris when 1 then 1 else 4 End))) end as ARGB_Colour
		from train.Sess  
			left join train.Courses on Sess.Course = Courses.ID
			left join train.Locations on Sess.Location = Locations.ID
		where Sess.MaxP > 0
		union
		select OtherActivity.Trainer, OtherActivity.[Date], OtherActivity.[Time],
			OtherActivity.Description, Locations.Location, null, null, null,
			category.Colour
		from train.OtherActivity
			left join train.Locations on OtherActivity.Location = Locations.ID
			left join train.category on OtherActivity.Category = category.ID
		where OtherActivity.Trainer is not null) coursesess on d.[Date] = coursesess.[Date] and Staff.ID = coursesess.Trainer and d.[Time] = coursesess.[AM/PM]
	where Staff.Trainer = 1 and Staff.[External] = 0 and Staff.LeftTrust = 0 
	order by Staff.Sname, Staff.Fname, d.[Date], d.[Time]
	
	return
end