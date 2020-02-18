2/4/2020
IDEAS FOR BLACKJACK

So while im still working on the rougelike I still wanted to get ideas in out of my head and onto paper so that I wouldnt forget it
-To make the deck I could make a list based on 52 integers so that I could add the integers multiple times
-then i could do logrithmic if checking to determine what the card is i.e.

if( num >=27){
	if(num >= 14){
	}
	else{
	...
	}
}
else{
	if(num >= 40){
	}
	else{
	...
	}
}

this way I can reduce down on the check time it takes to assign each card a point value.

Now I am just trying to figure out how to assign cards the sprite without typing the same code over and over and not having to call
the same function 52 times n decks.

2/8/2020
I never got to finish the rougelike because of me not realizing the completed game caused errors in the code, and of the fact that I 
still havent started blackjack. I have a couple hours before work to try some stuff out.

I ended up irreparably messing up my initial cards game project so much that I had to redownload it to even get it to work again. Its hard to 
learn the syntax and make this big program from the ground up. I am stressed because I cant figure this out and I need to put it down for a couple of
days to work on another class project due.

2/12/2020
I have talked to some classmates and some of them have made actual classes and now thinking about what they did I have come up with great ideas regarding the
card and have made a class. I was talking to kierstyn about how the card is set up with an image, that would take care of my sprite. and then it would take
care of the point value by reading the name of the sprite and converting it, specifically the last letter of the sprite, and would use a string to int on the 
last number of the number cards. This streamlines my last design by much and also improves the functionality of my code for future refactorization. 

I have work soon and I have to finish my project due tomorrow so im going to be rushing to turn this in on friday, so im a bit stressed. 

2/14/2020
After finally getting to work on my code I have been able to make a card and deck but my game manager has been going a bit rough. I cant seem to even figure out where
to start. I have made some buttons and images, and my List of cards of course but I just dont have the syntax or know how to string them together into something cohesive.
My card should assign points. My deck has create along that repeats. I created a shuffle function and then I had to use removeAt, because there is no popback for lists in C#.

2/15/2020
After talking with kierstyn again about their gameManager I was able to talk through most of it with them by making the mock-ups for all the methods and writing comments about
what each method should do and then when to call which function. I was able to get a little bit of it made before I have to head into work. Still have mostly everything to do,
if I had things in my scene then they would be populating correctly, I havent made anything or connected anything to the gameManager.

2/16/2020
Was able to finish most of my code before work, going to have to finish it tonight. hopefully this will allow me to turn it in "on time" still. And of course i need to finish
setting it all up.

Was able to get a hold of a friend as CSU Chico who is in thier game design program for unity. I had to wait for him after work and finished up my code, which he helped streamline
a bit by telling me where I could save on some logic, and he also helped me to impement my fancy slider tool and tie that to my bet. he also helped me to work through my code and
taught me how to use Debug.Log("Type_Error_Here"); that will show up in the unity console so you know where your code gets to, i.e. into which loops and checks it may or may not 
skip. was able to finish the basics for a bug free game will arange tomorrow sleep is now.

2/17/2020
Was able to finish setting up my UI except I had a problem with my shuffle function in where i cant use the new keyword,which cant be used in monobehavior, to make new cards to 
swap in my shuffle so I would be left with about 300 extra cards made per deck used and I cant figure out how to destroy them without the destroy method which requires monobehavior,
so I had to just pick a random index in my drawCard function and removeAt said index. This is very frustrating, but at this point I will take what I can get and be thankful.

If I had to do this over again I would start sooner, and make sure that I am more on top of my github. Also I would talk to classmates more so that we can bounce ideas off each other.


