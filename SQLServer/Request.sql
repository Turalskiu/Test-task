SELECT p.Title, c.Title FROM Product AS p
LEFT JOIN ProductAndCategory AS pac ON pac.ProductId = p.Id
LEFT JOIN Category AS c ON pac.CategoryId = c.Id