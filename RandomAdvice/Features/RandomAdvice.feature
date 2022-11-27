Feature: ReadRandomAdvice


Scenario: Read Advice
	When  send a request to read random advice
	Then  response status code should be OK