----------------------------------------------------------------------------
----------------------------------------------------------------------------
---- product --------- product_category---------- category -----------------
----- id --------------- product_id -------------- id ----------------------
----- name ------------- category_id ------------- name --------------------

SELECT product.name, category.name
FROM product_category
JOIN category
	ON category.id = product_category.category_id
RIGHT JOIN product
	ON product.id = product_category.product_id