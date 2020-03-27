create proc p_User
@name varchar(50),
@sex int,
@pageIndex int,
@pageSize  int,
@totalCount int out
as
begin
	declare @start int;
	declare @end int;
	set @start=(@pageIndex-1)*@pageSize
	set @end=@start+@pageSize;
	set @start=@start+1


	IF @sex>=0 AND LEN(@name)>0
	BEGIN 
		select * 
		from 
		(
			select ROW_NUMBER() over(order by Id ) rid ,* from [dbo].[UserInfo] where UserSex=@sex and UserName like '%'+@name+'%'
		) as t 
		where rid between @start and @end

		select @totalCount=count(1) from  [dbo].[UserInfo]  where UserSex=@sex and UserName like '%'+@name+'%'
	END
	ELSE IF @sex>=0 AND LEN(@name)=0
	BEGIN
		select * 
		from 
		(
			select ROW_NUMBER() over(order by Id ) rid ,* from [dbo].[UserInfo] where UserSex=@sex 
		) as t 
		where rid between @start and @end

		select @totalCount=count(1) from  [dbo].[UserInfo]  where UserSex=@sex 
	END
	ELSE  IF @sex<0 AND LEN(@name)>0
	BEGIN
		select * 
		from 
		(
			select ROW_NUMBER() over(order by Id ) rid ,* from [dbo].[UserInfo] where UserName like '%'+@name+'%'
		) as t 
		where rid between @start and @end

		select @totalCount=count(1) from  [dbo].[UserInfo]  where UserName like '%'+@name+'%'
	END
	ELSE
	BEGIN
		select * 
		from 
		(
			select ROW_NUMBER() over(order by Id ) rid ,* from [dbo].[UserInfo] 
		) as t 
		where rid between @start and @end

		select @totalCount=count(1) from  [dbo].[UserInfo]  
	END 
end
