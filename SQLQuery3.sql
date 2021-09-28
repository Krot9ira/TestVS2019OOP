
SELECT TOP (1) 
      [CustomerId], [Name]
  FROM [Order], [Customer] WHERE [CustomerId]=  [Customer].[Id] ORDER BY [Discount]