Feature: Start the game
    I want to start a new game
@acceptance 
Scenario Outline: Start the game
    Given The number of positions is <numPositionsBefore>
    And the current x position is <xPositionBefore>
    And the current y position is <yPositionBefore>
    When the game starts
    Then The number of positions will be <numPositionsAfter>
    And the current x position is <xPositionAfter>
    And the current y position is <yPositionAfter>
    Examples:
        | numPositionsBefore | xPositionBefore | yPositionBefore | numPositionsAfter | xPositionAfter | yPositionAfter | 
        | 0 | 0 | 0 | 100 | 0 | 0 |  
