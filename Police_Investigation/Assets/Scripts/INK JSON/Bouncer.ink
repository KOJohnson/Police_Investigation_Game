VAR openDoor = false
Hey, I’m sorry boss, you can’t come in, club’s full
->Introduction
== Introduction == 
* [Listen, we can do this the easy way, or the hard way. (flash revolver)] -> Intimidate
* [I’m looking for a girl by the name of Isabel Rosa, you heard of her.] -> Inquire
* [Hey, here’s $100, slide me in will ya?] -> Bribe
* [What is this place?] -> Question

== Intimidate ==
~openDoor = true
Alright, Alright, Jesus, you can come in, but be quick, and don’t say a fucking word.
* Thanks for your co-operation. -> END 

== Inquire == 
Fuck off, before I break your damn neck.
* Sorry, must of misheard me, my mistake -> Introduction

== Bribe ==
~openDoor = true
Damn, talking my kind of language. Alright, get in quick, and don’t tell anyone I let you in.
* I appreciate it -> END

== Question ==
What does it fucking look like? It's a nightclub, I guess it used to be a chruch? Who cares. Fuck off loser. -> Introduction 
