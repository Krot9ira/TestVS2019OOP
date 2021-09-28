SELECT [Customer].Name ,Sum(Product.Price*(1-ISNULL([Discount],0))) AS Sum
FROM [Customer], [Order], [OrderItem], [Product] WHERE Customer.Id=[Order].[CustomerId] AND Customer.[Name] = 'Мария' AND OrderItem.OrderId = [Order].Id AND OrderItem.ProductId = Product.Id GROUP BY [Customer].Name
