using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

public class NPBehaveBaseNode : Node {
	[Input] public string MainNode;
	[Input] public string Blackboard;
	[Input] public string Clock;
	private NPBehave.Node _mainNode;
	private NPBehave.Blackboard _blackboard;
	private NPBehave.Clock _clock;
	// Use this for initialization
	protected override void Init() {
		base.Init();
		
	}

	// Return the correct value of an output port when requested
	public override object GetValue(NodePort port) {
        if (port.fieldName == "MainNode")
        {
			//port.node.
        }
		else if(port.fieldName == "Blackboard")
        {

        }
		else if (port.fieldName == "Clock")
		{

		}
		return null; // Replace this
	}
}