import { test, expect } from '@playwright/test';

test('test', async ({ page }) => {
  await page.goto('https://localhost:7249/');
  await page.getByRole('link', { name: 'Login' }).click();
  await page.getByLabel('Email').click();
  await page.getByRole('link', { name: 'Register', exact: true }).click();
  await page.getByLabel('Email').click();
  await page.getByLabel('Email').fill('user@test.fr');
  await page.getByLabel('Email').press('End');
  await page.getByLabel('Email').press('Tab');
  await page.getByLabel('Password', { exact: true }).fill('Unsupermotdepasse0!');
  await page.getByLabel('Password', { exact: true }).press('Tab');
  await page.getByLabel('Confirm password').fill('Unsupermotdepasse0!');
  await page.getByRole('button', { name: 'Register' }).click();
  await page.getByRole('link', { name: 'Click here to confirm your account' }).click();
});