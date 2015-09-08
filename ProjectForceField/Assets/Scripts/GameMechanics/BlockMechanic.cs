using UnityEngine;
using System.Collections;

public class BlockMechanic : MonoBehaviour {
	private bool isMoveable;
	private bool isSpecial;
	private bool isAtOrigin;
	public GameObject block;
	private float maxHeight;
	private float minHeight;
	private float blockHeight;
	// Use this for initialization
	void Start () {
		block = GetComponent<GameObject>();
		maxHeight = 3f;
		minHeight = -3f;
		blockHeight = block.transform.localPosition.y;
	}
	
	// Update is called once per frame
	void Update () {
		maintainBoundary ();
		checkOrigin ();
	}

	void checkOrigin(){
		if (blockHeight == 0) {
			isAtOrigin = true;
		}
	}
	void maintainBoundary(){
		if (isMoveable) {
			if(blockHeight > maxHeight){
				blockHeight = maxHeight;
			}
			if(blockHeight < minHeight){
				blockHeight = minHeight;
			}
		} else {
			blockHeight = 0f;
		}
	}
	public bool getIsMoveable(){
		return isMoveable;
	}
	public bool getIsSpecial(){
		return isSpecial;
	}

	public bool getIsAtOrigin(){
		return isAtOrigin;
	}

	public float getMaxHeight(){
		return maxHeight;
	}

	public float getMinHeight(){
		return minHeight;
	}

	public float getBlockHeight(){
		return blockHeight;
	}

	public void setIsMoveable(bool boolean){
		isMoveable = boolean;
	}
	public void setIsSpecial(bool boolean){
		isSpecial = boolean;
	}
	
	public void setIsAtOrigin(bool boolean){
		isAtOrigin = boolean;
	}
	
	public void setMaxHeight(float height){
		maxHeight = height;
	}
	
	public void setMinHeight(float height){
		minHeight = height;
	}
	
	public void setBlockHeight(float height){
		blockHeight = height;
	}

}
