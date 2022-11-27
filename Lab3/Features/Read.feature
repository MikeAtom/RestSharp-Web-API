Feature: ReadBooking



Scenario: Read Bookings
	When send read  request
	Then expected OK response 
