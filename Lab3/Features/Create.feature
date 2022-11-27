Feature: CreateBooking



Scenario: Add  new booking
	Given firstname "Jim"
	And set lastname "Brown"
	And set a total price at "111"
	And set depositpaid as "true"
	And set the booking dates  checkin in "2018-01-01" and checkout in "2019-01-01"
	And set "Breakfast" as additional needs
	When send create booking request
	Then confirm that booking is created
	