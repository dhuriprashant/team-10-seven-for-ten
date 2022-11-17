Feature: Move in a direction

    I want to move my character. If they attempt to 
    move passed a boundry, the move results in no change in position.

@acceptance
Scenario Outline: Move in a direction
    Given the character starts at position with XCoordinates <startingPositionX>
    And starts at YCoordinates <startingPositionY>
    And the number of moves is <numOfMovesBeforeMove>
    And the player choses to move in <direction>
    When the character moves
    Then the character is now at position with XCoordinates <endingPositionX>
    And YCoordinates <endingPositionY>
    And the new number of moves <numOfMovesAfterMove> 
    Examples:
        |startingPositionX | startingPositionY | numOfMovesBeforeMove | direction | endingPositionX | endingPositionY | numOfMovesAfterMove |
        | 0 | 0 | 0 | NORTH | 0 | 1 | 1 |
        | 0 | 0 | 1 | SOUTH | 0 | 0 | 2 |