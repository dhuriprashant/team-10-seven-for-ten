Feature: Move in a direction

    I want to move my character. If they attempt to 
    move passed a boundry, the move results in no change in position.

    @acceptance
    Scenario Outline: Move in a direction
    Given the character starts at position with XCoordinates <startingPositionX>
    And starts at YCoordinates <startingPositionY>
    And the player comes to move in <direction>
    When the character moves
    Then the ch is now at position with XCoordinates <endingPositionX>
    And YCoordinates <endingPositionY>
    Examples:
        |startingPositionX | startingPositionY | direction | endingPositionX | endingPositionY |
        | 0 | 0 | NORTH | 0 | 1 |
        | 0 | 0 | SOUTH | 0 | 0 |