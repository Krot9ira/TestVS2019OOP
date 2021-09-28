SELECT YEAR([OrderDate]) AS Year, COUNT(Id) AS number
      
  FROM [Task2].[dbo].[Order] GROUP BY YEAR([OrderDate])