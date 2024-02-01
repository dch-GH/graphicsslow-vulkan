using Sandbox;

public sealed class MyComponent : Component
{
	public sealed class TestRenderer : SceneCustomObject
	{
		private Material _material;

		public TestRenderer( SceneWorld sceneWorld ) : base( sceneWorld )
		{
			_material = Material.Load( "error.vmat" );
		}

		public override void RenderSceneObject()
		{
			const int size = 8;
			for ( int y = 0; y < 64; y++ )
				for ( int x = 0; x < 64; x++ )
				{
					var tileRect = new Rect( x * size, y * size, size, size );
					Graphics.DrawQuad( tileRect, _material, Color.Yellow );
				}
		}
	}

	protected override void OnAwake()
	{
		base.OnAwake();
		var t = new TestRenderer( Scene.SceneWorld );
	}
}
