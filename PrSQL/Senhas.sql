SELECT 
    id,
    password, 
    CONVERT(VARCHAR(255), HASHBYTES('MD5', password), 2) AS md5
FROM 
    account