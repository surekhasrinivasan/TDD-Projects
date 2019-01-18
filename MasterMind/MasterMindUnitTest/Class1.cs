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
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] >= 6 || input[i] < 1)
                {
                    throw new System.ArgumentException("Number in the array cannot be greater than 6 or less than 1");
                }
            }
             return input;
        }

    }
}