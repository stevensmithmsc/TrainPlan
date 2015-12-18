create procedure train.AddMultiDayActivity
	@start date,
	@end date,
	@category int,
	@description varchar(20),
	@trainer int = null,
	@location int = null
as
begin
	declare @curdate date = @start
	
	while @curdate <= @end
	begin
		insert into train.OtherActivity(Trainer, Location, Category, [Date], [Time], Description)
		 values (@trainer, @location, @category, @curdate, 'AM', @description)
		insert into train.OtherActivity(Trainer, Location, Category, [Date], [Time], Description)
		 values (@trainer, @location, @category, @curdate, 'PM', @description)
		
		set @curdate = DATEADD(dd, 1, @curdate)
	end
end