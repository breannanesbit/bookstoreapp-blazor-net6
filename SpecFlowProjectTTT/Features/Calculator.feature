Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProjectTTT/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Pieces Can Be Played and Checked
Given 'x' plays in row 0 column 1 
Then 'x' is found in row 0 column 1  

Scenario: X Wins
Given 'x' plays in row 0 column 0
And 'x' plays in row 0 column 1 
And 'x' plays in row 0 column 2
And 'x' plays in row 1 column 1 
And 'x' plays in row 2 column 0 
And 'O' plays in row 1 column 0
And 'O' plays in row 1 column 2
And 'O' plays in row 2 column 1 
And 'O' plays in row 2 column 2
When checking for a winner
Then the winner of the game is x

Scenario: Normal Game Loop
Given 'x' plays in row 0 column 1 
And 'O' plays in row 1 column 1 
And 'x' plays in row 0 column 0
When checking for a winner
Then the winner of the game is none
When asking whos turn is next
Then player 'O' has the next turn