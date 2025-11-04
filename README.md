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
| 3 | \- | 4 | 4 | 4 | false | \- | \- | 1 | (num \!= code || stupid \== true) \-\> FALSE |
| 1 | 2 | 2 | 3 | 2 | \- | \- | \- | 2 |  i \<= 3 \-\> TRUE |
| 2 | \- | 2 | 3 | 2 | false | 2 | \- | 2 | (j \> 0 && num \!= code && stupid \== false) \-\> TRUE |
| 2 | 1 | 2 | 2 | 2 | false | 1 | \- | 2 | (j \> 0 && num \!= code && stupid \== false) \-\> FALSE |
| 3 | \- | 2 | 2 | 2 | false | \- | \- | 2 | (num \!= code || stupid \== true) \-\> FALSE |
| 1 | 3 | 2 | 5 | 2 | \- | \- | \- | 3 | i \<= 3 \-\> TRUE |
| 2 | \- | 2 | 5 | 2 | false | 2 | \- | 3 |  (j \> 0 && num \!= code && stupid \== false) \-\> TRUE |
| 2 | 1 | 2 | 1 | 2 | false | 1 | \- | 3 |  (j \> 0 && num \!= code && stupid \== false) \-\> TRUE |
| 2 | 2 | 2 | 2 | 2 | false | 0 | \- | 3 | (j \> 0 && num \!= code && stupid \== false) \-\> FALSE |
| 3 | \- | 2 | 2 | 2 | false | \- | \- | 3 | (num \!= code || stupid \== true) \-\> FALSE |
| 1 | \- | {System.Random} | 2 | \- | \- | \- | \- | 4 | i \<= 3 \-\> FALSE |
| 4 | \- |  | \- | \- | \- | \- | 2 | \- | op \!= 0 \-\> TRUE |

OUTPUT: 

- **"You have unlocked the final level. Prepare for battle\!"**

**Lose Case: num \=\! code && j \< 0** 

| instructions | iterations | variables |  |  |  |  |  |  | condition |
| :---- | :---- | ----- | :---- | :---- | :---- | :---- | :---- | :---- | :---- |
| \- | \- | randomNum | num | code | stupid | j | op | i | \- |
| 1 | \- | {System.Random} | 0 | 0 | false | \- | 2 | 1 | i \<= 3 \-\> TRUE |
| 1 | 1 | 1 | 4 | 1 | \- | \- | \- | 1 | i \<= 3 \-\> TRUE |
| 2 | \- | 1 | 4 | 1 | false | 2 | \- | 1 |  (j \> 0 && num \!= code && stupid \== false) \-\> TRUE |
| 2 | 1 | 1 | 3 | 1 | false | 1 | \- | 1 | (j \> 0 && num \!= code && stupid \== false) \-\> TRUE |
| 2 | 2 | 1 | 2 | 1 | \- | 0 | \- | 1 |  (j \> 0 && num \!= code && stupid \== false) \-\> FALSE |
| 3 | 1 | 1 | 2 | 1 | false | \- | 0 | 1 | (num \!= code && stupid \== true) \-\> TRUE |
| 4 | \- |  | \- | \- | \- | \- | 0 | \- | op \!= 0 \-\> FALSE |

OUTPUT: 

- **"The dragon has detected your presence and kicked you from the server\!"**

**Error Case: num \= 6** 

| instructions | iterations | variables |  |  |  |  |  |  | condition |
| :---- | :---- | ----- | :---- | :---- | :---- | :---- | :---- | :---- | :---- |
| \- | \- | randomNum | num | code | stupid | j | op | i | \- |
| 1 | \- | {System.Random} | 0 | 0 | false | \- | 2 | 1 | i \<= 3 \-\> TRUE |
| 1 | 1 | \- | 6 | \- | true | \- | \- | 1 | i \<= 3 \-\> TRUE |
| 2 | \- | 6 |  | 1 | true | 2 | \- | 1 |  (j \> 0 && num \!= code && stupid \== false) \-\> FALSE |
| 3 | 1 | 1 | 6 | 1 | true | 1 | 0 | 1 | (num \!= code && stupid \== true) \-\> TRUE |
| 4 | \- |  | \- | \- | true | \- | 0 | \- | op \!= 0 \-\> FALSE |

OUTPUT: 

- **You broke the lock... this has alerted the dragon RAMon, remember YOU CAN ONLY ENTER A NUMBER FROM 1 TO 5\!**  
- **"The dragon has detected your presence and kicked you from the server\!"**

**CHAPTER THREE:**

**Normal Case 1: totalMined \< 200**

| instructions | iterations | variables |  |  |  | condition |
| :---- | :---- | ----- | :---- | :---- | :---- | :---- |
| \- | \- | randomNum | totalMined | actualMined | i | \- |
| 1 | 1 | {System.Random} | \- | \- | 4 | i \>= 0 \-\> TRUE |
| 2 | 1 | 15 | 15 | 15 | 4 | actualMined \>= 51 \-\> FALSE |
| 1 | 1 | \- | 15 | 0 | 4 | i \>= 0 \-\> TRUE |
| 1 | 2 | 42 | 15 | 42 | 3 | i \>= 0 \-\> TRUE |
| 2 | 2 | 42 | 57 | 42 | 3 | actualMined \>= 51 \-\> FALSE |
| 1 | 2 | \- | 57 | 0 | 3 | i \>= 0 \-\> TRUE |
| 1 | 3 | 43 | 57 | 43 | 2 | i \>= 0 \-\> TRUE |
| 2 | 3 | 43 | 100 | 43 | 2 | actualMined \>= 51 \-\> FALSE |
| 1 | 3 | \- | 100 | 0 | 2 | i \>= 0 \-\> TRUE |
| 1 | 4 | 21 | 100 | 21 | 1 | i \>= 0 \-\> TRUE |
| 2 | 4 | 21 | 121 | 21 | 1 | actualMined \>= 51 \-\> FALSE |
| 1 | 4 | \- | 121 | 0 | 1 | i \>= 0 \-\> TRUE |
| 1 | 5 | 50 | 121 | 50 | 0 | i \>= 0 \-\> TRUE |
| 2 | 5 | 50 | 171 | 50 | 0 | actualMined \>= 51 \-\> FALSE |
| 1 | 5 |  | 171 | 0 | 0 | i \>= 0 \-\> TRUE |
| 1 | \- | \- | 171 | 0 | \-1 | i \>= 0 \-\> FALSE |
| 3 | \- | \- | 171 | \- | \- | totalMined \>= 200 \-\> FALSE |

OUTPUT: 

- **“Your magic card is still integrated. Time to defeat another dragon\!”**

**Normal Case 2: totalMined**  

| instructions | iterations | variables |  |  |  | condition |
| :---- | :---- | ----- | :---- | :---- | :---- | :---- |
| \- | \- | randomNum | totalMined | actualMined | i | \- |
| 1 | 1 | {System.Random} | \- | \- | 4 | i \>= 0 \-\> TRUE |
| 2 | 1 | 15 | 15 | 15 | 4 | actualMined \>= 51 \-\> FALSE |
| 1 | 1 | \- | 15 | 0 | 4 | i \>= 0 \-\> TRUE |
| 1 | 2 | 43 | 15 | 43 | 3 | i \>= 0 \-\> TRUE |
| 2 | 2 | 43 | 58 | 43 | 3 | actualMined \>= 51 \-\> FALSE |
| 1 | 2 | \- | 58 | 0 | 3 | i \>= 0 \-\> TRUE |
| 1 | 3 | 43 | 58 | 43 | 2 | i \>= 0 \-\> TRUE |
| 2 | 3 | 43 | 101 | 43 | 2 | actualMined \>= 51 \-\> FALSE |
| 1 | 3 | \- | 101 | 0 | 2 | i \>= 0 \-\> TRUE |
| 1 | 4 | 49 | 101 | 49 | 1 | i \>= 0 \-\> TRUE |
| 2 | 4 | 49 | 150 | 49 | 1 | actualMined \>= 51 \-\> FALSE |
| 1 | 4 | \- | 150 | 0 | 1 | i \>= 0 \-\> TRUE |
| 1 | 5 | 50 | 150 | 50 | 0 | i \>= 0 \-\> TRUE |
| 2 | 5 | 50 | 200 | 50 | 0 | actualMined \>= 51 \-\> FALSE |
| 1 | 5 |  | 200 | 0 | 0 | i \>= 0 \-\> TRUE |
| 1 | \- | \- | 200 | 0 | \-1 | i \>= 0 \-\> FALSE |
| 3 | \- | \- | 200 | \- | \- | totalMined \>= 200 \-\> TRUE |

OUTPUT: 

- **“You have unlocked the golden GPU\! Your spells now run at 120fps\!”**

