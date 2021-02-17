--1.View Menu Item List Admin(TYUC001)
--a.Add data into menu_item table.
insert into menu_item values
(1,'Sandwich',99.00,'yes','2017-03-15','Main Course','yes'),
(2,'Burger', 129.00,'yes','2017-12-23','Main Course','No'),
(3,'Pizza',149.00,'yes','2017-08-21','Main Course','No'),
(4,'French Fries',57.00,'No','2017-07-02','Starters','yes'),
(5,'Chocolate Brownie',32.00,'yes','2022-11-02','Dessert','yes')

--b.Frame SQL query to get all menu items
select *from menu_item



--2.View Menu Item List Customer (TYUC002)
--a.Frame SQL query to get all menu items which after launch date and is active.
select * from menu_item where me_active='yes' and me_date_of_launch is not null



--3.Edit Menu Item (TYUC003)
--a.Frame SQL query to get a menu items based on Menu Item Id
select*from menu_item where me_id=(select me_id from menu_item where me_name='Chocolate Brownie');

--b.Frame update SQL menu_items table to update all the columns values based on Menu Item Id
update menu_item set me_name='Ice Cream',me_price='100.00', me_active='yes', me_date_of_launch='2017-03-15',me_category='Desert',me_free_delivery='yes'
where me_id in(select me_id from menu_item where me_name='Burger')
select*from menu_item


--4.Add to Cart (TYUC004)
--a.Frame insert scripts for adding data into user and cart tables.
insert into users values
(1,'Mahitha'),
(2,'Mahi')
select *from users
 insert into cart values
 (1,1,1),
 (2,1,3),
 (3,1,4)
 select *from cart



-- 5.View Cart (TYUC005)
--a.Frame SQL query to get all menu items in a particular user’s cart
SELECT users.us_name, menu_item.me_name, menu_item.me_free_delivery, menu_item.me_price
FROM ((menu_item INNER JOIN cart ON cart.ct_pr_id= menu_item.me_id)
JOIN users ON users.us_id=cart.ct_us_id)

--b.Frame SQL query to get the total price of all menu items in a particular user’s cart
SELECT distinct(users.us_name),sum(menu_item.me_price) as 'Total Price'
FROM ((menu_item INNER JOIN cart ON cart.ct_pr_id= menu_item.me_id)
JOIN users ON users.us_id=cart.ct_us_id) group by us_name

--6.Remove Item from Cart (TYUC006)
--a.Frame SQL query to remove a menu items from Cart based on User Id and Menu Item Id
delete from cart where ct_us_id in(select us_id from users where us_name='Mahitha') and ct_pr_id in(select me_id from menu_item where me_name='Sandwich');
select * from cart;
