Select Customer_ID, Count(transaction_date) from transaksi
group by Customer_ID
order by count(transaction_date) desc, customer_id asc
