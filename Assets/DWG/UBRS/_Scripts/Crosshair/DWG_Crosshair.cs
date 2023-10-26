// Using - Engine - UI
using UnityEngine;
using UnityEngine.UI;

// Namespace - UBRS.DWG_Crosshair
namespace UBRS.DWG_Crosshair
{
    // Public - Class - DWG_Crosshair
    public class DWG_Crosshair : MonoBehaviour
    {
        
        // Public - Image - CrossTop
        public Image CrossTop;

        // Public - Image - CrossLeft
        public Image CrossLeft;

        // Public - Image - CrossCenter
        //public Image CrossCenter;        

        // Public - Image - CrossRight
        public Image CrossRight;

        // Public - Image - CrossBottom
        public Image CrossBottom;                        

        // Public - Bool - CrosshairEnabled - True
        public bool CrosshairEnabled = true;
        
        // Private - RectTransform - Crosshair
        private RectTransform Crosshair; // The RecTransform of Crosshair UI element.
        
        // Public - Rigidbody - CharacterRigidbody
        public Rigidbody CharacterRigidbody;
        
        // Public - Float - IdleSize - 75
        public float IdleSize = 75;

        // Public - Float - MaxSize - 250
        public float MaxSize = 250;

        // Public - Float - Speed - 7.5
        public float Speed = 7.5f;

        // Private - Float - CurrentSize
        private float CurrentSize;

        // Let's Start

        // Private - Void - Start
        private void Start() {

            // Crosshair - GetComponent - RectTransform
            Crosshair = GetComponent<RectTransform>();

        } // Close - Private - Void - Start

        // Let's Update

        // Update Is Called Once Per Frame
        
        // Private - Void - Update
        private void Update() {

            // Check If Player Is Currently Moving And Lerp CurrentSize To The Appropriate Value

            // If - CharacterIsMoving
            if (CharacterIsMoving)
            {
                
                // CurrentSize
                CurrentSize = Mathf.Lerp(CurrentSize, MaxSize, Time.deltaTime * Speed);

            } // Close - If - CharacterIsMoving

            // Else
            else
            {
                
                // CurrentSize
                CurrentSize = Mathf.Lerp(CurrentSize, IdleSize, Time.deltaTime * Speed);

            } // Close - Else

            // Set the Crosshair's Size To The CurrentSize Value
            Crosshair.sizeDelta = new Vector2(CurrentSize, CurrentSize);

        } // Close - Private - Void - Update

        // Let's LateUpdate

        // LateUpdate Is Called Once Per Frame

        // Public - Void - LateUpdate
        public void LateUpdate()
        {

            // Let's Enable The Crosshair

            // If CrosshairEnabled Is True
            if (CrosshairEnabled == true)
            {

                // Image - CrossTop - gameObject - SetActive - True
                CrossTop.gameObject.SetActive(true);

                // Image - CrossLeft- gameObject - SetActive - True
                CrossLeft.gameObject.SetActive(true);

                // Image - CrossCenter - gameObject - SetActive - True
                //CrossCenter.gameObject.SetActive(true);                

                // Image - CrossRight - gameObject - SetActive - True
                CrossRight.gameObject.SetActive(true);

                // Image - CrossBottom - gameObject - SetActive - True
                CrossBottom.gameObject.SetActive(true);

                // GetComponent - DWG_Crosshair - Enabled - True
                GetComponent<DWG_Crosshair>().enabled = true;

                // Debug - Log - Crosshair Enabled
                Debug.Log("The Crosshair is enabled.");

            } // Close - If CrosshairEnabled Is True

            // Let's Disable The Crosshair

            // Else If CrosshairEnabled Is False
            else if (CrosshairEnabled == false) 
            {
                 
                // Image - CrossTop - gameObject - SetActive - False
                CrossTop.gameObject.SetActive(false);

                // Image - CrossLeft - gameObject - SetActive - False
                CrossLeft.gameObject.SetActive(false);

                // Image - CrossCenter - gameObject - SetActive - False
                //CrossCenter.gameObject.SetActive(false);

                // Image - CrossRight - gameObject - SetActive - False
                CrossRight.gameObject.SetActive(false);

                // Image - CrossBottom - gameObject - SetActive - False
                CrossBottom.gameObject.SetActive(false);

                // GetComponent - DWG_Crosshair - Enabled - False
                GetComponent<DWG_Crosshair>().enabled = false;

                // Debug - Log - Crosshair Disabled
                Debug.Log("The Crosshair is disabled.");

            } // Close - Else If CrosshairEnabled Is False

        } // Close - Public - Void - LateUpdate

        // Bool To Check If The Player Is Currently Moving

        // Bool - CharacterIsMoving
        private bool CharacterIsMoving
        {
            
            // Get
            get
            {

                // If We Have Assigned A Rigidbody, Check If Its Velocity Is Not Equal To Zero. If So, Return True

                // If - CharacterRigidbody - Not Null
                if (CharacterRigidbody != null)
                {

                    // If CharacterRigidbody - velocity - sqrMagnitude Not 0
                    if (CharacterRigidbody.velocity.sqrMagnitude != 0)
                    {

                        // Return - True
                        return true;

                    } // Close - If CharacterRigidbody - Velocity - sqrMagnitude Not 0

                    // Else
                    else
                    {

                        // Return - False
                        return false;

                    } // Close - Else

                } // Close - If - CharacterRigidbody - Not Null

                // If No Rigidbody Is Assigned, Check Input Axis Instead

                // If - Input - Horizontal - Vertical - Mouse X - Mouse - Y - Not Equal To 0
                if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0 || Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
                {

                    // Return - True
                    return true;

                } // Close - If - Input - Horizontal - Vertical - Mouse X - Mouse - Y - Not Equal To 0

                // Else
                else
                {

                    // Return - False
                    return false;

                } // Close - Else

            } // Close - Get

        } // Close - Bool - CharacterIsMoving

    } // Close - Public - Class - DWG_Crosshair

} // Close - Namespace - UBRS.DWG_Crosshair
