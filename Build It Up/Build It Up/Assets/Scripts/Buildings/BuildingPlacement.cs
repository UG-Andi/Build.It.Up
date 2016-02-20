using UnityEngine;
using System.Collections;

public class BuildingPlacement : MonoBehaviour {

    private PlaceableBuildings placeableBuilding;
    private PlaceableBuildings placeableBuildingOld;
    private Transform currentBuilding;
    private bool hasPlaced;

    public LayerMask buildingsMask;

	void Update ()
    {
        Vector3 m = Input.mousePosition;
        m = new Vector3(m.x, m.y, transform.position.y);
        Vector3 p = GetComponent<Camera>().ScreenToWorldPoint(m);

        if (currentBuilding != null && !hasPlaced)
        {
            currentBuilding.position = new Vector3(Mathf.Round(p.x / 1) * 1, 0, Mathf.Round(p.z / 0.4f) * 0.4f);

            if (Input.GetMouseButtonDown(0))
            {
                if (IsLegalPosition())
                {
                    hasPlaced = true;
                    placeableBuilding.isPlaced = true;
                }
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 rayVector = p - transform.position;
                RaycastHit hit = new RaycastHit();
                Ray ray = new Ray(new Vector3(p.x, p.y, p.z), rayVector);
                if (Physics.Raycast(ray, out hit, Mathf.Infinity, buildingsMask))
                {
                    if (placeableBuildingOld != null)
                    {
                        placeableBuildingOld.SetSelected(false);
                    }
                    hit.collider.gameObject.GetComponent<PlaceableBuildings>().SetSelected(true);
                    placeableBuildingOld = hit.collider.gameObject.GetComponent<PlaceableBuildings>();
                }

                else
                {
                    if (placeableBuildingOld != null)
                    {
                        placeableBuildingOld.SetSelected(false);
                    }
                }
            }
        }
	}

    bool IsLegalPosition()
    {
        if (placeableBuilding.colliders.Count > 0)
        {
            return false;
        }
        return true;
    }

    public void SetItem(GameObject b)
    {
        hasPlaced = false;
        currentBuilding = ((GameObject)Instantiate(b)).transform;
        placeableBuilding = currentBuilding.GetComponent<PlaceableBuildings>();
    }
}
