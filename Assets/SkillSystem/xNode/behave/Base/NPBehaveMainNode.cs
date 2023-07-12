using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;
using NPNode = NPBehave.Node;

public class NPBehaveMainNode : Node {
	[Output] public string MainNode;
	// Use this for initialization
	protected override void Init() {
		base.Init();
		
	}

	// Return the correct value of an output port when requested
	public override object GetValue(NodePort port) {
		return null; // Replace this
	}

	//public NPBehave.Node GetMainNode()
 //   {

	//	return new NPNode("");
 //   }
}