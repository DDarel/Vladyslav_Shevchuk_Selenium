Feature: AddNewJob

Scenario: AddJob
Given User logged in with data
| UserName | Password |
| Admin | admin123 |
When User click on Admin
And User click on Job Titles
And User click on Add
And User insert data
| JobTitle | JobDescription | Note          |
| Student   | Bad job anyway  | Intresting note | 
And User click on Save
Then User delete Student
And User click Yes, Delete