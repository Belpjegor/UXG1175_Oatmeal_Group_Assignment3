using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InventoryDemo
{
    public class PlayerController : MonoBehaviour
    {
        public float moveSpeed = 5f;
        public float interactRadius = 2f;
        public GameObject orbObj;

        private Vector2 moveDir;

        private bool isInventoryOpen = false;

        // Start is called before the first frame update
        void Start()
        {
            //set this object as main player
            Game.SetPlayer(this);

            //load scene 1 if not already loaded
            if (!SceneLoader.HasScene("Room1Scene") && !SceneLoader.HasScene("Room2Scene"))
            {
                GoToRoom("Room1Scene", 0);
            }

            //check if inventory is open
            isInventoryOpen = SceneLoader.HasScene("InventoryHUD");

            //set initial game state
            Game.InitializeGameData();

            //refresh orb display on player
            RefreshOrbDisplay();
        }

        // Update is called once per frame
        void Update()
        {
            //get horizontal movement
            moveDir = new Vector2(Input.GetAxis("Horizontal"), 0);

            //detect interaction key
            if (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                //detect interaction target(s)
                Collider2D[] targetList = Physics2D.OverlapCircleAll(transform.position, interactRadius);

                foreach (Collider2D target in targetList)
                {
                    //trigger interaction if interface found
                    IInteract interactScript = target.GetComponent<IInteract>();
                    if (interactScript != null) interactScript.Interact();
                }
            }

            //detect inventory key
            if (Input.GetKeyDown(KeyCode.I)) ToggleInventory();
        }

        void FixedUpdate()
        {
            //move player according to detected move direction
            this.GetComponent<Rigidbody2D>().MovePosition((Vector2)transform.position + (moveDir * moveSpeed * Time.fixedDeltaTime));
        }

        private void ToggleInventory()
        {
            if (isInventoryOpen)
            {
                //close inventory
                StartCoroutine(SceneLoader.UnLoadSceneCo("InventoryHUD"));

                isInventoryOpen = false;
            }
            else
            {
                //open inventory
                StartCoroutine(SceneLoader.LoadSceneCo("InventoryHUD"));

                isInventoryOpen = true;
            }
        }

        public void SetPlayerPosition(float xPos)
        {
            //force player location
            transform.localPosition = new Vector3(xPos, -1f, 0);
        }

        public void GoToRoom(string aRoomString, float aTargetPos)
        {
            //start coroutine to load target room
            StartCoroutine(GoToRoomCo(aRoomString, aTargetPos));
        }

        private IEnumerator GoToRoomCo(string aRoomString, float aTargetPos)
        {
            //unload current room
            if (Game.GetCurrentRoom() != null) yield return SceneLoader.UnLoadSceneCo(Game.GetCurrentRoom().roomName);

            //load target room
            yield return SceneLoader.LoadSceneCo(aRoomString);

            //set location in target room
            SetPlayerPosition(aTargetPos);
        }

        public void RefreshOrbDisplay()
        {
            //show orb on player if orb is on player
            orbObj.SetActive(Game.GetOrbLocation() == OrbLocation.PLAYER);
        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(transform.position, interactRadius);
        }
    }
}