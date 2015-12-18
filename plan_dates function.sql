create function train.plandates 
	(@startdate datetime,
	 @enddate datetime,
	 @incweekend bit = 0)
	 returns @t table (ID int not null, [Date] date not null, [Time] Char(2) not null)
begin
	declare @curdate as datetime
	declare @n as int

	set @curdate = @startdate
	set @n = 1
	
	while @curdate <= @enddate
	begin
		if @incweekend = 1 or DATEPART(dw, @curdate) not in (1, 7)
		begin
			insert into @t values (@n, @curdate, 'AM')
			insert into @t values (@n + 1, @curdate, 'PM')
			set @n = @n + 2
		end
		
		set @curdate = DATEADD(dd, 1, @curdate)
	end

	return
end