Crosshair
----------------------------------------------------------------------------------

Description:

Create a Dynamic FPS Crosshair for your Unity projects.


Manual Setup Instruction:
-------------------------

* Simply follow the instruction for manual setup found below.

-----------------------------------------------------------------------------------

Step 1: Create Empty -> UI  * Unless you already have one
___________________________________________________________________________________


1.A) Create Empty and Rename it to: "UI"

1.B) This is a "Holder"

1.C) Add Layer: "UI"

1.D) Modify as follows as this is simply a "holder":

Position: X: 0  Y: 0  Z: 0
Rotation: X: 0  Y: 0  Z: 0
Scale:    X: 1  Y: 1  Z: 1


-----------------------------------------------------------------------------------

Step 2: Create in UI -> Canvas * Unless you already have one
___________________________________________________________________________________

2.A) Inside the Holder called: "UI" that you just created go ahead and create a
     "Canvas"

2.B) Make sure the "Layer" is set as: "UI"

2.B) Modify:

Canvas
-------

Render Mode: Screen Space - Overlay
Pixel Perfect: Selected

Canvas Scaler
-------------

UI Scale Mode: Scale with Screen Size
Reference Resolution: X: 1920  Y: 1080
Match: Width
Reference Pixels Per: 1920


-----------------------------------------------------------------------------------

Step 3: Create in UI -> Create Panel -> Crosshair (Holder)
___________________________________________________________________________________


3.A) Inside "Canvas", create a "Panel" and rename it to "Crosshair"

     Note: this will be our Crosshair "holder".

3.B) Remove the image component from the panel

3.C) Make sure the "Layer" is set as: "UI"

3.D) Modify:

Rect Transform
---------------

Anchors: Middle & Center

Position: X: 0  Y: 0  Z: 0
Width: 100
Height: 100


-----------------------------------------------------------------------------------

Step 4: Create in  -> Create Image -> Cross Top (Image)
___________________________________________________________________________________


4.A) In UI -> Canvas -> Crosshair, create "Image"  & rename "Cross Top"

4.B) Make sure the layer is set to: "UI"

4.C) Modify:

Rect Transform
---------------

Anchors: Top & Center

Position: X: 0  Y: 0  Z: 0
Width: 5
Height: 25

Pivot: X: 0.5  Y: 1

Color Hex: #D01B1B


-----------------------------------------------------------------------------------

Step 5: Create in  -> Create Image -> Cross Left (Image)
___________________________________________________________________________________


5.A) In UI -> Canvas -> Crosshair, create "Image"  & rename "Cross Left"

5.B) Make sure the layer is set to: "UI"

5.C) Modify:

Rect Transform
---------------

Anchors: Middle & Left

Position: X: 0  Y: 0  Z: 0
Width: 25
Height: 5

Pivot: X: 0  Y: 0.5

Color Hex: #D01B1B


-----------------------------------------------------------------------------------

Step 6: Create in  -> Create Image -> Cross Center (Image) * Optional
___________________________________________________________________________________


6.A)  In UI -> Canvas -> Crosshair, create "Image"  & rename "Cross Center"

6.B)  Make sure the layer is set to: "UI"

6.C) Modify:

Rect Transform
---------------

Anchors: Middle & Center

Position: X: 0  Y: 0  Z: 0
Width: 10
Height: 10

Pivot: X: 0.5  Y: 0.5

Color Hex: #FFFFFF

Or also add a source image is another option.


NOTE: As this is optional, if you want to use a center image you would need to 
uncomment the commented out the related sections in script that pertain to center 
image.


-----------------------------------------------------------------------------------

Step 7: Create in  -> Create Image -> Cross Right (Image)
___________________________________________________________________________________


7.A) In UI -> Canvas -> Crosshair, create "Image"  & rename "Cross Right"

7.B) Make sure the layer is set to: "UI"

7.C) Modify:

Rect Transform
---------------

Anchors: Middle & Right

Position: X: 0  Y: 0  Z: 0
Width: 25
Height: 5

Pivot: X: 1  Y: 0.5

Color Hex: #D01B1B


-----------------------------------------------------------------------------------

Step 8: Create in  -> Create Image -> Cross Bottom (Image)
___________________________________________________________________________________


8.A) In UI -> Canvas -> Crosshair, create "Image"  & rename "Cross Bottom"

8.B) Make sure the layer is set to: "UI"

8.C) Modify:

Rect Transform
---------------

Anchors: Bottom & Right

Position: X: 0  Y: 0  Z: 0
Width: 5
Height: 25

Pivot: X: 0.5  Y: 0

Color Hex: #D01B1B


-----------------------------------------------------------------------------------

Step 9: Add Script in  -> UI -> Canvas -> Crosshair
___________________________________________________________________________________

9.A) Go back into UI -> Canvas -> Crosshair "Holder"


9.B) Add the component script: "DWG_Crosshair.cs"

9.C)

Modify:

DWG_Crosshair (Script):
-------------------------

Script: DWG_Crosshair
Cross Top: Cross Top (Image)
Cross Left: Cross Left (Image)
Cross Right: Cross Right (Image)
Cross Bottom: Cross Bottom (Image)
Crosshair Enabled: "Checked" -> Yes  * Checked by default
Character Rigibody: * only needed if you are using a rigibody fpscontroller
Idle Size: 75
Max Size: 250
Speed: 7.5


* NOTE: as noted earlier in Step 6, if you notice this step, Step 9, does not 
  mention the optional: Cross Center (Image) in the script setup.

  ie:

  Cross Center: Cross Center (Image)

 as that is optional and as noted before that part of the script is commented 
 out and in order to use such, those commented out section would need to be 
 uncommented. Hopefully that makes sense.

-----------------------------------------------------------------------------------


That is it and concludes the Crosshair setup steps.

Best of Luck!
