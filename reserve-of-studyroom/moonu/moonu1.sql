create table reserver(id number primary key, name varchar(20))
/
insert into reserver values(1933010, '±è½ÂÇö')
/
insert into reserver values(1933005, 'Á¤¿¹Á÷')
/
insert into reserver values(1933024, '¹ÚÁø¿µ')
/
create table r_room_res(room_res_no number primary key, room_no number, room_seat_no varchar(20), room_res_time varchar(20))
/
