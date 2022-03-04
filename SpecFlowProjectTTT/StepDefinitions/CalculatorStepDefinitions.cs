using tictactoeDemo;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowProjectTTT.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly ScenarioContext context;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            context = scenarioContext;
            var ticTacToe = new TicTacToe();
            context.Add("ttt", ticTacToe);

        }

        [Given(@"'([^']*)' plays in row (.*) column (.*)")]
        public void GivenPlaysInRowColumn(string x, int p1, int p2)
        {
            var setCell = context.Get<TicTacToe>("ttt");
            bool setting = setCell.setCell(x, p1, p2);
            //context.Add("wasPlaced", succes);
        }


        [Then(@"'([^']*)' is found in row (.*) column (.*)")]
        public void ThenIsFoundInRowColumn(string x, int p1, int p2)
        {
            var getCell = context.Get<TicTacToe>("ttt");
            var succes = getCell.getCell( p1, p2);
            succes.Should().Be(x);
        }

        [When(@"checking for a winner")]
        public void WhenCheckingForAWinner()
        {
           var tttAccess = context.Get<TicTacToe>("ttt");
           string winner = tttAccess.Winner();
            context.Add("winner", winner);
        }

        [Then(@"the winner of the game is (.*)")]
        public void ThenTheWinnerOfTheGameIs(string x)
        {
            var whoWon = context.Get<string>("winner");
            if(whoWon == null)
            {
                whoWon = "none";
            }
            whoWon.Should().Be(x);
        }

        [When(@"asking whos turn is next")]
        public void WhenAskingWhosTurnIsNext()
        {
            var whosTurn = context.Get<TicTacToe>("ttt");
            string nextTurn = whosTurn.currPlayer;
            context.Add("nextTurn", nextTurn);

        }

        [Then(@"player '([^']*)' has the next turn")]
        public void ThenPlayerHasTheNextTurn(string player)
        {
            player.Should().Be(context.Get<string>("nextTurn"));
        }

    }
}