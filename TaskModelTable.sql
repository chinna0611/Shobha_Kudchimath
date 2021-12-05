
create table TaskModel(
TaskId integer,
ProjectId integer,
Status varchar2(50),
AssignedUserId integer,
Detail varchar2(50),
CreatedOn DATETIME);

insert into TaskModel(TaskId,ProjectId,Status,AssignedUserId,Detail,CreatedOn) values (1,11,'Approved', 11, 'Details about task and project','2021-10-13');

insert into TaskModel(TaskId,ProjectId,Status,AssignedUserId,Detail,CreatedOn) values (2,12,'Approval Pending', 12, 'Details task and project','2021-08-13');