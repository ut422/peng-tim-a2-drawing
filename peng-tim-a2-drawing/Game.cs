// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color black = new Color(0); // black color
        Color defaultColor = Color.Black; // default circle color
        Color smileyfacedefaultColor = Color.White; // initialize the smiley default color to white

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            // set window title and size
            Window.SetTitle("2D interactive thing");
            Window.SetSize(800, 600); // initial window size

            // sets target FPS
            Window.TargetFPS = 60;

            // sets line color for outlines
            Draw.LineColor = Color.Red;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // resets the screen
            Window.ClearBackground(Color.OffWhite);

            // get the mouse position
            float mouseX = Input.GetMouseX();
            float mouseY = Input.GetMouseY();



            // coordinates for smiley face
            float faceX = 400; // X coordinate for the face center
            float faceY = 300; // Y coordinate for the face center

            // left mouse click
            if (Input.IsMouseButtonDown(MouseInput.Left))
            {
                smileyfacedefaultColor = black; // changes to black on left click
            }
            else
            {
                smileyfacedefaultColor = Color.White; // changes to black on left click
            }

            // Draw the face
            Draw.FillColor = smileyfacedefaultColor; // fills the color for the face
            Draw.Circle(faceX - 0, faceY - 0, 150); // draws the face

            // Draw the eyes (two smaller circles)
            Draw.FillColor = Color.White; // white for the eyes
            Draw.LineColor = Color.White; // white outline
            Draw.Circle(faceX - 35, faceY - 20, 15); // left eye
            Draw.Circle(faceX + 35, faceY - 20, 15); // right eye

            // Draw the mouth (using white circles)
            Draw.FillColor = Color.White; // white for the mouth
            Draw.LineColor = Color.White; // white outline for mouth
            Draw.Circle(faceX - 50, faceY + 60, 15); // mouth part 1
            Draw.Circle(faceX + 50, faceY + 60, 15); // mouth part 2
            Draw.Circle(faceX - 20, faceY + 90, 15); // mouth part 3
            Draw.Circle(faceX + 20, faceY + 90, 15); // mouth part 4
            
        }
    }
}
