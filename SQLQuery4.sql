
create table products

(
product_id int,
product_name varchar(50),
is_recycable bit,
is_lowfat bit
);

SELECT product_id, product_name FROM products WHERE is_recycable='True' AND is_lowfat='True';
