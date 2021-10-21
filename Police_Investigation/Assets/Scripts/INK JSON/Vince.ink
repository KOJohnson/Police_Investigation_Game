VAR Bow = false
Hello, can I help you Mr…? 
->Introduction
== Introduction ==
* [White, Anderson White, private detective. I’m looking for a girl named Isabel Rosa, ring a bell?] -> Girl
* [Mr is fine for now] -> Evasive
* [Nice place you got here, you the owner?] -> Question
* [You don’t need to know my name; they won’t be much use in the afterlife.] -> Intimidate
* [Show Evidence] -> Evidence

== Girl ==
 Hmm, I don’t think that name has crossed my path, although, we get many patrons here. You understand. 
* [Do you have a ledger of some kind, CCTV?] -> Ledger
* [I think you’re full of shit] -> Intimidate
* [Funny, this says otherwise (Show Evidence)] -> Evidence


== Evasive == 
Okay then… Mister, what is it you need of me? I’m a very busy man, as you can probably surmise. 
* [Care to explain this?] (Show evidence) -> Evidence
* [Nothing urgent, just wondering what you do here. Are you the owner?] -> Question

== Question == 
I am Indeed, Vincent Caudarl IV. At your service, I do hope I can help you, Mr?
~ Bow = true 
* [Anderson White, Detective. I’m looking for a girl by the name of Isabel Rosa, you heard of her?] -> Girl

== Intimidate ==
Heavens! Calm down dear sir. I meant you no harm, how can I be of service? 
* [I’m looking for a girl by the name of Isabel Rosa. Heard of her?] -> Girl
* [Oh, nothing, sorry for bothering you.] -> END
* [Yeah? Well explain this (Show Evidence).] -> Evidence

== Ledger ==
I’m afraid we don’t have CCTV, the Swamp marsh and old architecture… It doesn’t lend itself well to modern wiring and technology, I hope you understand. 
* [Okay, I understand, I will check around some more and get back to you] -> END
* [Care to explain this then? (Show Evidence)] -> Evidence

== Evidence ==
(Looks at the evidence) Do you believe in fate detective?
* [What the fuck does that mean?] -> WTF
* [Yes.] -> Yes
* [No.] -> No 
* [I’m not sure.] -> Indecisive  

== WTF ==
I mean, Anderson White, do you believe that our lives are dictated by a higher power? 
* [Yes.] -> Yes
* [No.] -> No
* [I’m not sure.] -> Indecisive 

== Yes ==
And why do believe that? To assuage your guilt about your drinking? Your daughter? 
* [How do you know that? Who the fuck are you?] -> Progress

== No ==
Interesting, I suppose this is the first step towards putting your drinking and daughter’s death behind you. 
* [How do you know that? Who the fuck are you?] -> Progress

== Indecisive == 
I think everything and everyone has a purpose Mr Anderson. Your drinking and the death of your daughter brought you to this place. Brought you straight to me.
* [How do you know that? Who the fuck are you?] -> Progress 

== Progress ==
All will be revealed in due time. Go and meet Clara, she will lead you to the girl. As to what happens after that, it’s up to you. 
* [Fuck you asshole, When I find her you're all going down] -> Dracuuuula

== Dracuuuula ==
I will say no more, go now to her, while you still have time. -> END 
