CREATE PROCEDURE sproc_tblCustomer_FilterByCustomerId
	--parameter to store the customerId we are looking for
	@CustomerId int
AS
	SELECT * FROM tblCustomer WHERE CustomerId = @CustomerId
RETURN 0
