declare module app {
	export interface IComment {
		id: number;
		userId: number;
		projectId: number;
		description: string;
	}
}
