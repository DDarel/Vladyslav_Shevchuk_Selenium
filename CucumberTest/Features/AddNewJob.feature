Feature: AddNewJob

Scenario: AddJob
Given I have logged into application
| UserName | Password |
| Admin | admin123 |
When I add new job title
| JobTitle | JobDescription | Note          |
| Student   | Bad job anyway  | Intresting note | 
Then Job title is added
When I remove job title
Then job title is removed