create table reserver(id number primary key, name varchar(20))
/
insert into reserver values(1933010, '�����')
/
insert into reserver values(1933005, '������')
/
insert into reserver values(1933024, '������')
/
create table r_room_res(room_res_no number primary key, room_no varchar(30), stuName varchar(20), stuID varchar(20), room_seat_no varchar(30), room_res_time varchar(30))
/