﻿using System;
using System.Collections;
using System.Collections.Generic;
using RPG.Combat;
using RPG.Movement;
using UnityEngine;

namespace RPG.Control.Mover
{
    public class Mover : MonoBehaviour 
    {
        private void Update()
        {
            InteractWithCombat();
            InteractWithMovement();
        }

        private void InteractWithCombat()
        {
            RaycastHit[] hits = Physics.RaycastAll(GetMouseRay());
            foreach (RaycastHit hit in hits)
            {
                CombatTarget target = hit.transform.GetComponent<CombatTarget>();
                if (target == null) continue;
                if (Input.GetMouseButtonDown(0))
                {
                    GetComponent<Fighter>().Attack(target);
                }
            }
        }

        private void InteractWithMovement()
        {
            if (Input.GetMouseButton(0))
            {
                MoveToCursor();
            }
        }

        private void MoveToCursor()
        {
            print(Camera.main);
            RaycastHit hit;
            bool hasHit = Physics.Raycast(GetMouseRay(), out hit);
            if (hasHit)
            {
                GetComponent<PlayerMover>().MoveTo(hit.point);
                
            }
        }

        private static Ray GetMouseRay()
        {
            return Camera.main.ScreenPointToRay(Input.mousePosition);
        }
    }

}
