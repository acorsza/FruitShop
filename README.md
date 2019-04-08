# FruitShop

FruitShop is an API that calculates the receipt for purchases

To run the project, download the solution and after running the Solution with VS, go to the localhost URL and send a GET request to the route /fruitshop/run

Example:

https://localhost:5001/fruitshop/run

The response is the receipt like below:

{"total":5.4,"receiptId":1,"purchase":[{"purchaseId":1,"product":"Pear","quantity":5},{"purchaseId":1,"product":"Orange","quantity":5},{"purchaseId":1,"product":"Apple","quantity":6},{"purchaseId":1,"product":"Cucumber","quantity":8}]}
