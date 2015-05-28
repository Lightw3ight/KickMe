 declare module app {
	 export interface IProject {
		 id: number;
		 title: string;
		 description: string;
		 locationId: number;
		 categoryId: number;
		 startDate: string;
		 isCompleted: boolean;
		 bannerImagePath: string;
		 imagePath: string;
	 }
}
