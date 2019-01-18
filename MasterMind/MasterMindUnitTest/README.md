the game mastermind has the following rules:

1. a code is randomly generated containing 4 digits.
2. the user gets 6 chances to guess the code.
3. a score is given on each guess.
4. the score contains two values: a correct number meaning the the code contains X correct numbers. examples

- code: 1 2 3 4, guess: 8 8 8 8, score 0
- code: 1 2 3 4, guess: 4 3 2 1, score 4
- code: 1 2 3 4, guess: 2 2 2 2, score 1

5. the second score value is the correct position meaning a correct number is in the right spot. example

- code: 1 2 3 4, guess: 8 8 8 8, score 0 0
- code: 1 2 3 4, guess: 4 3 2 1, score 4 0
- code: 1 2 3 4, guess: 2 2 2 2, score 1 1

6. a score of 4 4 means the user got the code right and should win.
7. the game keeps track of old guesses and informs the user of a repeat guess.

Rules

1. do not go back to prior branches or commits.
2. do not submit any pull requests to the repo.
3. do not look at any forks of the problem.
4. recommendation is to download the repo as a zip file and create a fresh repo from the contents. this prevents a link between the two and ensures green squares on github.
5. DO NOT open any of the testX.cs files until you are ready for the next test (current test passes and the refactor and retrospective phases are done)

instructions to complete the practice:

1. To complete the challenge pick one partner (CoderA) to start the first test which is given as a guidline.
2. After CoderA completes the first test their next task is to create the next test. (The title of each next test is provided as during the interview the test is either written by the interviewer or by the Coder with an instruction similar to the name of the test).
3. The second partner (CoderB) codes the test to passing.
4. CoderB then partakes in the first round of refactoring.
5. After steps 3 and 4 prior to creating next test CoderA can chime in with other refactor ideas to help with learning as well as have a retrospective for that phase.
6. CoderB writes the next test.
7. CoderA then repeats steps 3, 4, 5, and 6 taking the role that CoderB did.

Repeat until finished with all tests. remember to have a retrospective before the next test is written.
NOTE: it may be neccessary for the one coding a solution to a test to question the test. A discussion between the two can occur to confirm that the test is a valid test. The Coder of the solution should wait until the test creator has confirmed they are done creating the test. Give the Test creator the chance to realize any issues with the test prior to questioning the test.
