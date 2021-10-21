VAR hasKey = false
Hello, can I help you? -> Introduction

== Introduction == 

*[Hello, I'm detective Anderson, I'm looking for a girl by the name of Isabel Rosa, does that name ring a bell?] -> Direct
*[What is your name, what do you do here?] -> Inquire
*[Oh sorry, I didn't mean to disturb you. Carry on with your work.] -> END

== Direct ==
N-no, i've never heard of anyone with that name, please leave me alone. I've got work to do. 
*[Your boss said to come talk to you, something about a key to a door?] -> B_unlock
*[I found this bloody name tag, care to explain?] -> C_unlock

== Inquire == 
O-oh, my name is Clara, i'm the cleaner here, if you don't mind, I need to get on with my shift.
*[Ahh, apologies, i'll let you go then] -> END
*[Who's the boss around here?] -> Vince

== B_unlock ==
O-oh, well if Vincent has told you, you must be working with him. Don't tell him I said this, but you really don't want to go down there.
*[Fuck-sake woman, just give me the damn key!] -> Intimidate
*[Why not?] -> Basement
*[you must have misheard me, what I actually said was...] -> Introduction

== Intimidate ==
~hasKey = true
Fine, don't say I didn't warn you. (She hands you the key) -> END

== C_unlock ==
~hasKey = true
I-I... (She wordlessly takes out the key and hands it to you) They make me do these things, please be careful
*[Thanks for your co-operation ma'am.] -> END
*[Better not be anything crazy down there, or I'm gonna start shooting. Starting with you.] -> END 

== Basement ==
I can't say, he'll kill me, you should leave, while you still can. -> END

== Vince ==
Oh, that'd be Vince, he's nice. pays me on time, gives me bonuses, there's something wrong with things here though... I shouldn't have said that. Please leave me. -> END 