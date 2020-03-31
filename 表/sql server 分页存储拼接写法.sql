declare @count int;
exec p_user 0,'',1,5,@count out
select @count;

alter proc p_user
@id int,
@username varchar(50),
@pageindex int,
@pagesize int,
@totalcount int out
as
begin
----------------------1.计算查询数据的开始、结束 -----------------------------
	declare @start int;
	declare @end int;
	
	set @start=(@pageindex-1)*@pagesize;
	set @end=@start+@pagesize;
	set @start=@start+1;
	
----------------------2.拼接查询条件 -----------------------------	
	declare @wheresql nvarchar(500);
	set @wheresql=' where 1=1 ';
	
	if @id>0
	begin
		set @wheresql=@wheresql+' and id= '+ CONVERT(nvarchar, @id );
	end

	if LEN(@username)>0
	begin
		set @wheresql=@wheresql+' and name  like ''%'+@username+'%''';
	end

----------------------3.开始拼接分页查询语句 -----------------------------
	declare @selectsql nvarchar(500); --注意 此处需要为nvarchar，int类型 转换为nvarchar类型
	set @selectsql =' 	select * from ( 
	select ROW_NUMBER() over( order by id  ) as rowid,* from UserInfo'+ @wheresql+'
	)  as t where t.rowid between '+CONVERT(nvarchar,@start )+' and '+CONVERT(nvarchar, @end);
	
----------------------4.开始拼接查询总条数-----------------------------
	declare @countsql nvarchar(500);--注意 此处需要为nvarchar
	set @countsql ='select @totalcount=count(1)  from UserInfo'+ @wheresql;
----------------------5.执行语句-----------------------------
--执行查询语句
exec (@selectsql);
 exec sp_executesql @countsql,N' @totalcount int out ',@totalcount out;
end