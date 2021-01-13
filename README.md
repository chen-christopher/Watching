# Watching

### Project Description
This project is an escape room that follows a man in a wheelchair. It was created in Unity. The user is situated in an abandoned hospital that's eerily creepy. As the user tries to escape, the user will find out snippets of the man's past. This project was designed with the constraints of a Google Cardboard in mind. 

### Character:

The character is a man sitting on a wheelchair. we wanted to create an escape room based off of someone in a wheelchair and the disabilities you would face as you progress. <br/>
<img src="./Images/character.png" width=600>

### Gameplay:

When the game starts, the user is situated in a room with a glowing book. Once the user clicks on the book, it reveals that there are four things that the user must find. <br/>
<img src="./Images/clues.png" width=600> 

To move and explore, the user must hold down on the left click. The user must click around to try find where the clues are hidden. Once all clues are gathered, there is a door at the end that asks for a passcode to leave. Once the user leaves the room, a cut scene will appear. <br/>

<img src="./Images/exit.png" width=800>



### Environment:

The original design is based off a mental asylum: we wanted something that was creepy but not gory. As the user progresses with the game, the user will notice that it's completely abandoned and there are multiple blood spotches. The space is divided into a few different areas. Firstly, there is the ward in which you wake up in. There’s a bed next you with an album, a cart blocking your path, a chair, and a sink. <br/>
<img src="./Images/hospital1.png" width=800>

Once you exit, there’s a hallway that connects to the rest of the space. <br/>
<img src="./Images/hospital2.png" width=800>

From there onwards, the user can explore the space and there’s a room on the right side with a table.<br/>
<img src="./Images/hospital3.png" width=800>

If we go forwards from the hallway, we enter the operating room. There’s a bunch of miscellaneous objects, a recycle bin and surgical equipment.<br/>
<img src="./Images/hospital4.png" width=800>

If you turn left, there’s another hallway and it leads to another part of the hospital. If you turn left from that hallway, there is another ward. In this ward, there’s two beds and a drawer.<br/>
<img src="./Images/hospital5.png" width=800>

On the right side from the hallway, there’s an empty room with a box.<br/>
<img src="./Images/hospital6.png" width=800>

The last part of the hospital is the exit where there is a large metal door and a broken screen.<br/>
<img src="./Images/hospital7.png" width=800>

### Thoughts and Discussion

From the beginning, we needed implement a first person view and we decided that we wanted the user to be on a wheelchair. To implement this, we combined the wheelchair asset with the character model (the character looks like a zombie). We then added a character controller script that had the ray-cast, first person camera view, and interactions. If the player is close to an interact-able object and clicks it while the ray-cast is hovering it, an image will display.

### Implementation

I spent the bulk of my time animating the door and writing the script to open the door. I animated it via Unity and incorporated a simple script to test it out in the beginning (press space to open door). These largely adhered to the tutorials that Sarah posted. Once I made sure the animation was working, I added the keypad via GUI. I followed a tutorial on Youtube to complete this part: https://www.youtube.com/watch?v=ne41wItQmdo.

The script can be described as follows: when the user approaches the box collider of the door, it tells the user that if the user clicks one more time, a keypad will appear (this is done via onTriggerEnter and onTriggerExit along with boolean values).

If the user clicks, it opens the keypad (clicking turns a boolean variable keypad to true). The user can then hover and click on the buttons. The password is set in the code (“35296”) and there is a variable called input that is initially “‘. When a user presses a button, input = input + “x” with “x” being what number they press. Once the input is equal to the password, the door opens (another boolean variable is set to true). Pressing the “?” button will prompt a GUI interface to show writing “Enter a 5 digit password.” Pressing the “x” will turn the keypad boolean variable to false, closing it, and allowing the user to move again.

### Reflection

I felt like we definitely met our expectations in creating an escape room that had a “storyness” to it. I felt like there was also a motivation for the player to explore and try to escape. I am very proud of the work that we produced and I had a lot of fun making this. I was so absorbed in making this that I lost track of time and was 45 minutes late to a class. However, there are definitely some things that we could improve on. However, for the given time frame I am extremely happy with the work that we created.




