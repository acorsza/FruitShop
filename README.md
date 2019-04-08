# FruitShop

FruitShop is an API that calculates the receipt for purchases

To run the project, download the solution and after running the Solution with VS, go to the localhost URL and send a GET request to the route /fruitshop/run

Example:

https://localhost:5001/fruitshop/run

The response is the receipt like below:

{"total":5.4,"receiptId":1,"purchase":[{"purchaseId":1,"product":"Pear","quantity":5},{"purchaseId":1,"product":"Orange","quantity":5},{"purchaseId":1,"product":"Apple","quantity":6},{"purchaseId":1,"product":"Cucumber","quantity":8}]}

For this example, the total should be 26.15 considering all the offers.

Correct response:

{"total":26.15,"receiptId":1,"purchase":[{"purchaseId":1,"product":"Pear","quantity":5},{"purchaseId":1,"product":"Orange","quantity":5},{"purchaseId":1,"product":"Apple","quantity":6},{"purchaseId":1,"product":"Cucumber","quantity":8}]}

Total per product

Pear     Total quantity: 4  Total Price: 3    Offer: +1 in Quantity    -> Final Quantity: 5

Orange   Total quantity: 5  Total Price: 5    Offer: 25% discount      -> Final Price after Discount: 3.75

Apple    Total quantity: 6  Total Price: 5.4  Offer: No Offer

Cucumber Total quantity: 7  Total Price: 14   Offer: +1 in Quantity    -> Final Quantity: 8

Total price is 26.15
