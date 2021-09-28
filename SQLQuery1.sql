
SELECT [Name]
  FROM [Customer], [Order] 
  WHERE 
  [Order].CustomerId = [Customer].[Id] AND 
  YEAR([Order].OrderDate) = 2018;