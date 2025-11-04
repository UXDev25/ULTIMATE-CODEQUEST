**CHAPTER ONE:**

**Normal Case 1: name \-\> “albaricoque”** 

| instructions | iterations | variables |  |  |  |  | condition |
| :---- | :---- | ----- | :---- | :---- | :---- | :---- | :---- |
| \- | \- | name  | randomNum | actualPow | totalPow | i | \- |
| 1 | \- | albaricoque | {System.Random} | 0 | 0 | \- | \- |
| 2 | \- | albaricoque | \- | \- | \- | \- | (String.IsNullOrWhiteSpace(name) OR name.Length \> 15\) \-\> FALSE |
| 3 | \- | \- | {System.Random} | 0 | 0 | 1 | i \<= 5 \-\> TRUE |
| 3 | 1 | \- | {System.Random} | 0 | 0 | 1 | i \<= 5 \-\> TRUE |
| 3 | 1 | \- | 7 | 7 | 7 | 1 |  i \<= 5 \-\> TRUE |
| 3 | 2 | \- | {System.Random} | 7 | 7 | 2 | i \<= 5 \-\> TRUE |
| 3 | 2 | \- | 5 | 5 | 12 | 2 | i \<= 5 \-\> TRUE |
| 3 | 3 | \- | {System.Random} | 5 | 12 | 3 | i \<= 5 \-\> TRUE |
| 3 | 3 | \- | 9 | 9 | 21 | 3 | i \<= 5 \-\> TRUE |
| 3 | 4 | \- | {System.Random} | 9 | 21 | 4 | i \<= 5 \-\> TRUE |
| 3 | 4 | \- | 4 | 4 | 25 | 4 | i \<= 5 \-\> TRUE |
| 3 | 5 | \- | {System.Random} | 9 | 25 | 5 | i \<= 5 \-\> TRUE |
| 3 | 5 | \- | 7 | 7 | 32 | 5 | i \<= 5 \-\> TRUE |
| 3 | 6 | \- | 7 | 7 | 32 | 6 | i \<= 5 \-\> FALSE |
| 4 | \- | \- | \- | \- | 32 | \- | totalPow \<= 20 \-\> FALSE |
| 4 | \- | \- | \- | \- | 32 | \- | totalPow \<= 30 \-\> FALSE |
| 4 | \- | \- |  | \- | 32 | \- | totalPow \<= 40 \-\> TRUE |

OUTPUT: 

- **Yeah\! your power is pretty impressive\! you can invoke all sorts of dragons and conjure different spells**  
- **albaricoque, The red magician, That's your level.**

**Error Case 1: name \-\> “”**

| instructions | iterations | variables |  |  |  |  | condition |
| :---- | :---- | ----- | :---- | :---- | :---- | :---- | :---- |
| \- | \- | name  | randomNum | actualPow | totalPow | i | \- |
| 1 | \- |  | {System.Random} | 0 | 0 | \- | \- |
| 2 | \- |  | \- | \- | \- | \- | (String.IsNullOrWhiteSpace(name) OR name.Length \> 15\) \-\> TRUE |

OUTPUT: 

- **Invalid name, please input a name with at least one character and shorter than 15 characters.**

**Error Case 2: name \-\> “AsjabadUltimatePro”**

| instructions | iterations | variables |  |  |  |  | condition |
| :---- | :---- | ----- | :---- | :---- | :---- | :---- | :---- |
| \- | \- | name  | randomNum | actualPow | totalPow | i | \- |
| 1 | \- | AsjabadUltimatePro | {System.Random} | 0 | 0 | \- | \- |
| 2 | \- | AsjabadUltimatePro | \- | \- | \- | \- | (String.IsNullOrWhiteSpace(name) OR name.Length \> 15\) \-\> TRUE |

OUTPUT: 

- **Invalid name, please input a name with at least one character and shorter than 15 characters.**

**CHAPTER TWO:**

**Normal Case 1: num \= 4,3,2,5,1,2 (for each iteration)**

| instructions | iterations | variables |  |  |  |  |  |  | condition |
| :---- | :---- | ----- | :---- | :---- | :---- | :---- | :---- | :---- | :---- |
| \- | \- | randomNum | num | code | stupid | j | op | i | \- |
| 1 | \- | {System.Random} | 0 | 0 | false | \- | 2 | 1 | i \<= 3 \-\> TRUE |
| 1 | 1 | 4 | 4 | 4 | \- | \- | \- | 1 | i \<= 3 \-\> TRUE |
| 2 | \- | 4 | 4 | 4 | false | 2 | \- | 1 |  (j \> 0 && num \!= code && stupid \== false) \-\> FALSE |
| 3 | \- | 4 | 4 | 4 | false | \- | \- | 1 | (num \!= code && stupid \== true) \-\> FALSE |
| 1 | 2 | 2 | 3 | 2 | \- | \- | \- | 2 |  i \<= 3 \-\> TRUE |
| 2 | \- | 2 | 3 | 2 | false | 2 | \- | 2 | (j \> 0 && num \!= code && stupid \== false) \-\> TRUE |
| 2 | 1 | 2 | 2 | 2 | false | 1 | \- | 2 | (j \> 0 && num \!= code && stupid \== false) \-\> FALSE |
| 3 | \- | 2 | 2 | 2 | false | \- | \- | 2 | (num \!= code && stupid \== true) \-\> FALSE |
| 1 | 3 | 2 | 5 | 2 | \- | \- | \- | 3 | i \<= 3 \-\> TRUE |
| 2 | \- | 2 | 5 | 2 | false | 2 | \- | 3 |  (j \> 0 && num \!= code && stupid \== false) \-\> TRUE |
| 2 | 1 | 2 | 1 | 2 | false | 1 | \- | 3 |  (j \> 0 && num \!= code && stupid \== false) \-\> TRUE |
| 2 | 2 | 2 | 2 | 2 | false | 0 | \- | 5 | (j \> 0 && num \!= code && stupid \== false) \-\> FALSE |
| 3 | \- | 2 | 2 | 2 | false | \- | \- | 3 | (num \!= code && stupid \== true) \-\> FALSE |
| 1 | \- | {System.Random} | 2 | \- | \- | \- | \- | 4 | i \<= 3 \-\> FALSE |
| 4 | \- |  | \- | \- | \- | \- | 2 | \- | op \!= 0 \-\> TRUE |

OUTPUT: 

- **"You have unlocked the final level. Prepare for battle\!"**