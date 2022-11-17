Feature: Check Character has a name , use DEFAULT_NAME if none.

    I want to make sure the character has a name. If there is no name use the 
    DEFAULT_NAME.


@acceptance
Scenario Outline: Name Character
    Given the character has no name <startingName>
    When the game starts
    Then assign character default name <Name>
    Examples:
        |startingName | Name |
        | null | DEFAULT_NAME |
