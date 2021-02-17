create database truYum
use truYum

create table users (
us_id int primary key,
us_name varchar(60)
)

create table menu_item (
me_id int primary key,
me_name varchar(100),
me_price  float,
me_active varchar(3),
me_date_of_launch date,
me_category varchar(45),
me_free_delivery varchar(3)
)

create table cart (
ct_id int primary key,
ct_us_id int foreign key references users(us_id),
ct_pr_id int foreign key references menu_item(me_id)
)

