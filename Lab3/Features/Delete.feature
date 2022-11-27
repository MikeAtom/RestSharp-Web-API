Feature: DeleteBooking

Scenario: Delete Booking
	When make delete request
	Then check if the  record is deleted