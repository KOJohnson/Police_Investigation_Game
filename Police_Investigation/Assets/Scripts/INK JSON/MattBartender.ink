VAR isDrunk = false
Hey, what can I get you pal?
Welcome to the Bloody Mary
->Introduction 
== Introduction ==
* [I'm looking for a young girl by the name of Isabel Rosa, does that name ring a bell] -> Girl 
* [Quite a nightclub you have here, did you remodel it from an old church or something?] -> Establishment
* [Hey, can I buy a Whiskey?] -> Whiskey
* [I'm a cop asshole. Break yourself.] -> Combat
+ [Sorry, could you repeat that?] -> Repeat

== Girl ==
(Glances to the side for a moment before meeting your eyes again.) No, never heard of her, she missing or something?
* [I'm a detective, following up a lead, heard this place has a... reputation for certain markets.] -> Hostile

== Hostile == 
Listen here, here in the Bayou we don't take kindly to people accusing us of unsightly dealings. Especially not from your 'kind'. 
* [Hey I didn't mean anything by it, let's take a step back a second before things get a bit too heated.] -> Introduction 
* [I'm gonna search this place top to bottom, by force if I must.] -> Combat
* [Just doing a favour for a worried mother, I'm sure she's just fucked off with her boyfriend or something, know what I mean?] -> Disregard

== Disregard ==
Hmph, just mind your tongue. 
* [Just doing a favour for a worried mother, I'm sure she's just pissed off with her boyfriend or something, know what I mean?] -> Disregard
* [Sorry, I think you misheard me, I'm looking for something else.] -> Introduction



== Establishment ==
Noticed huh? Yeah, this place has been around since before you were born, albeit not as a nightclub. (A small smile passes his lips)
* [Big place for a nightclub, you got much staff?] -> Inquire
* [Excuse me, I gotta use the bathroom] -> END
* [Yeah? well i'm gonna tear this fuckin' place down, starting with you.] -> Combat

== Inquire ==
Well, there's Sebastian, you passed him on the way here, giant tattooed guy? He's the bouncer. 
There's Sarah, you'll probably see her cleaning around the nightclub when it isn't busy. 
And there's Vincent, the boss, you can find him upstairs, although it's best not to disturb him, you piss him off and Seb will make you choose a window. 
* [Is that so? That's good to know, thanks for the chat] -> END
* [There ain't gonna be no fuckin' windows left by the time i'm done with it.] -> Combat

== Whiskey ==
~isDrunk = true
Sure thing pal, enjoy!  -> END

== Combat ==
Fuck you pig!  -> END

== Repeat ==
Sorry, could you repeat that? the music is loud as hell -> Introduction