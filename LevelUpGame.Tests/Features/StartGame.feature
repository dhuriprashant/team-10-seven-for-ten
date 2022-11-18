Feature: Start the game
    I want to start a new game
@acceptance 
Scenario Outline: Start the game
    Given the character name is <characterNameBefore>
    And number of positions is <numPositionsBefore>
    And the current x position is <xPositionBefore>
    And the current y position is <yPositionBefore>
    And the number of moves before initiliazation is <numberOfMovesBefore>
    When game starts
    Then the character name should be <characterNameAfter>
    And the number of positions will be <numPositionsAfter>
    And the current x position should be <xPositionAfter>
    And the current y position should be <yPositionAfter>
    And the number of moves after initiliazation is <numberOfMovesAfter>
    Examples:
        | characterNameBefore | numPositionsBefore | xPositionBefore | yPositionBefore | numberOfMovesBefore | characterNameAfter | numPositionsAfter | xPositionAfter | yPositionAfter | numberOfMovesAfter |
        |  | 0 | 0 | 0 | 0 | DEFAULT_NAME | 100 | 0 | 0 | 0 |
