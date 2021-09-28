SELECT [Customer].Name ,Sum(Product.Price*(1-ISNULL([Discount],0))) AS sum INTO tempTable
FROM [Customer], [Order], [OrderItem], [Product] WHERE Customer.Id=[Order].[CustomerId]  AND OrderItem.OrderId = [Order].Id AND OrderItem.ProductId = Product.Id GROUP BY [Customer].Name HAVING [Customer].Name != 'Мария'
SELECT Sum([sum]) AS sum INTO tempTable2
FROM tempTable
SELECT  (Sum(Product.Price*(1-ISNULL([Discount],0)))/[tempTable2].[sum]) AS proportion
FROM [Customer], [Order], [OrderItem], [Product], [tempTable2] WHERE Customer.Id=[Order].[CustomerId] AND Customer.[Name] = 'Мария' AND OrderItem.OrderId = [Order].Id AND OrderItem.ProductId = Product.Id GROUP BY [tempTable2].[sum]
DROP TABLE tempTable;
DROP TABLE tempTable2;