using System;

namespace Mastermind.Service
{
    public class Game
    {
    private readonly ICodeGenerator _codeGenerator;
    private readonly GameStatus _gameStatus;

    private readonly GameInputValidator _validator;
    public int[]code;

       public Game(ICodeGenerator generator, GameStatus gameStatus, GameInputValidator validator)
       {
            _codeGenerator = generator;
            code = _codeGenerator.Generate();
            _gameStatus = gameStatus;
            _validator = validator;            
       }

        public int[] CheckScore(int[] input)
        {
            if (input.Length > 4 || input.Length < 4)
            {
                throw new System.ArgumentException("Length of the array should not be greater than 4 or less than 4");
            }
            return input;
        }

    }
}