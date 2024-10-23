### System Description

#### Overview

The `String Calculator` is a utility designed to process expressions and return the sum of numbers contained int this.
This is handling based on specific rules.

#### Functional Requirements
*Basic Addition*:
- Function: `add`
- Input: A string containing 0, 1, or 2 numbers separated by commas.
- Output: The sum of the numbers as a string.
- Example: `"1"` returns `"1"`, `"1.1,2.2"` returns `"3.3`.
*Multiple Numbers*:
- The `add` method can handle an unknown number of arguments.  
*Newline as Separator*:
- The `add` method can handle newlines as separators.
- Example: `"1\n2,3"` returns `"6"`.
*Custom Separators*:
- The `add` method can handle different delimiters specified at the beginning of the input.
- Example: `"//;\n1;2"` returns `"3"`.
- returns `"'|' expected but ',' found at position 3."`.  
